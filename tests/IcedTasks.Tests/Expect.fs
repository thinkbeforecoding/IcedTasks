namespace IcedTasks.Tests

open System
open System.Threading.Tasks
open IcedTasks

module TestHelpers =
    let makeDisposable (callback) =
        { new System.IDisposable with
            member this.Dispose() = callback ()
        }

    let makeAsyncDisposable (callback) =
        { new System.IAsyncDisposable with
            member this.DisposeAsync() = callback ()
        }

module Expect =
    open Expecto

    /// Expects the passed function to throw `'texn`.
    [<RequiresExplicitTypeArguments>]
    let throwsTAsync<'texn when 'texn :> exn> f message = async {
        let! thrown = async {
            try
                do! f ()
                return ValueNone
            with e ->
                return ValueSome e
        }

        match thrown with
        | ValueSome e when e.GetType().IsAssignableFrom typeof<'texn> ->
            failtestf
                "%s. Expected f to throw an exn of type %s, but one of type %s was thrown."
                message
                (typeof<'texn>.FullName)
                (e.GetType().FullName)
        | ValueSome _ -> ()
        | _ -> failtestf "%s. Expected f to throw." message
    }


type Expect =

    static member CancellationRequested(operation: Async<_>) =
        Expect.throwsTAsync<OperationCanceledException>
            (fun () -> operation)
            "Should have been cancelled"

    static member CancellationRequested(operation: ValueTask<unit>) =
        Expect.CancellationRequested(Async.AwaitValueTask operation)
        |> Async.AsValueTask

    static member CancellationRequested(operation: Task<_>) =
        Expect.CancellationRequested(Async.AwaitTask operation)
        |> Async.StartImmediateAsTask

    static member CancellationRequested(operation: ColdTask<_>) =
        Expect.CancellationRequested(Async.AwaitColdTask operation)
        |> Async.AsColdTask

    static member CancellationRequested(operation: CancellableTask<_>) =
        Expect.CancellationRequested(Async.AwaitCancellableTask operation)
        |> Async.AsCancellableTask

    static member CancellationRequested(operation: CancellableValueTask<_>) =
        Expect.CancellationRequested(Async.AwaitCancellableValueTask operation)
        |> Async.AsCancellableTask
