# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.5.2] - 2023-02-21

### Changed
- [Using new SRTP helpers](https://github.com/TheAngryByrd/IcedTasks/pull/19) Credits @TheAngryByrd

## [0.5.1] - 2022-12-17

### Changed
- [Fixed Doc comments and changed StartAsTask to StartImmediateAsTask](https://github.com/TheAngryByrd/IcedTasks/pull/17) Credits @TheAngryByrd

## [0.5.0] - 2022-12-08

### Added
- [Adds BindReturn/MergeSources to allow for parallel computations using and!](https://github.com/TheAngryByrd/IcedTasks/pull/16) Credits @TheAngryByrd

## [0.5.0-beta001] - 2022-12-08

### Added
- [Adds BindReturn/MergeSources to allow for parallel computations using and!](https://github.com/TheAngryByrd/IcedTasks/pull/16) Credits @TheAngryByrd

## [0.4.0] - 2022-12-01

### Added
- [Adds ValueTask and CancellableValueTask](https://github.com/TheAngryByrd/IcedTasks/pull/15) Credits @TheAngryByrd

## [0.3.2] - 2022-11-30

### Changed
- [Refactor Binds to Source members](https://github.com/TheAngryByrd/IcedTasks/pull/12) Credits @TheAngryByrd
- [Expand TFMs to netstandard2.0 and 2.1](https://github.com/TheAngryByrd/IcedTasks/pull/13) Credits @TheAngryByrd
- [InlineIfLambda was just adding compile time without benefit](https://github.com/TheAngryByrd/IcedTasks/pull/14) Credits @TheAngryByrd

## [0.3.2-beta002] - 2022-11-30

### Changed

- [Refactor Binds to Source members](https://github.com/TheAngryByrd/IcedTasks/pull/12) Credits @TheAngryByrd
- [Expand TFMs to netstandard2.0 and 2.1](https://github.com/TheAngryByrd/IcedTasks/pull/13) Credits @TheAngryByrd
- [InlineIfLambda was just adding compile time without benefit](https://github.com/TheAngryByrd/IcedTasks/pull/14) Credits @TheAngryByrd

## [0.3.2-beta001] - 2022-11-30

### Changed
- [Refactor Binds to Source members](https://github.com/TheAngryByrd/IcedTasks/pull/12) Credits @TheAngryByrd

## [0.3.1] - 2022-11-27

### Changed
- [Test refactoring and docs](https://github.com/TheAngryByrd/IcedTasks/pull/11). Credits @TheAngryByrd

## [0.3.1-beta002] - 2022-11-27

### Changed
- [Test refactoring and docs](https://github.com/TheAngryByrd/IcedTasks/pull/11). Credits @TheAngryByrd

## [0.3.1-beta001] - 2022-11-27

### Changed
- [Test refactoring and docs](https://github.com/TheAngryByrd/IcedTasks/pull/11). Credits @TheAngryByrd

## [0.3.0] - 2022-11-08

### Fixed
- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed
- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.3.0-beta007] - 2022-11-08

### Fixed
- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed
- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.3.0-beta006] - 2022-11-08

### Fixed
- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed
- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.3.0-beta005] - 2022-11-07

### Fixed
- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed
- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.3.0-beta004] - 2022-11-07

### Fixed
- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed
- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.3.0-beta003] - 2022-11-07

### Fixed
- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed
- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.3.0-beta002] - 2022-11-07

### Fixed
- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed
- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.3.0-beta001] - 2022-11-06

### Fixed

- [Verifies upstream F# fix for task resumption code](https://github.com/TheAngryByrd/IcedTasks/issues/8)

### Changed

- [Updates to F# 7](https://github.com/TheAngryByrd/IcedTasks/issues/8)

## [0.2.0] - 2022-03-22

### Added

- [Adds parallelAsync computation expression](https://github.com/TheAngryByrd/IcedTasks/pull/7)

## [0.1.1] - 2022-03-07

### Changed

- Small memory performance improvement by changing how state machine was being copied
- Remove excess InlineIfLambda. This was causing excessive compile times without any performance benefits.

## [0.1.0] - 2022-03-06

### Added

- Adds ColdTask and CancellableTask

### Changed

- Removes excess namespaces, adds baseline to benchmarks
- Increased soeed and lowered memory usage of ColdTask and CancellableTask
- Build for netstandard2.0 and netstandard2.1

[Unreleased]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.5.2...HEAD
[0.5.2]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.5.1...v0.5.2
[0.5.1]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.5.0...v0.5.1
[0.5.0]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.4.0...v0.5.0
[0.5.0-beta001]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.4.0...v0.5.0-beta001
[0.4.0]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.3.2...v0.4.0
[0.3.2]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.3.1...v0.3.2
[0.3.2-beta002]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.3.1...v0.3.2-beta002
[0.3.2-beta001]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.3.1...v0.3.2-beta001
[0.3.1]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.3.0...v0.3.1
[0.3.1-beta002]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.3.0...v0.3.1-beta002
[0.3.1-beta001]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.3.0...v0.3.1-beta001
[0.3.0]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0
[0.3.0-beta007]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0-beta007
[0.3.0-beta006]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0-beta006
[0.3.0-beta005]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0-beta005
[0.3.0-beta004]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0-beta004
[0.3.0-beta003]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0-beta003
[0.3.0-beta002]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0-beta002
[0.3.0-beta001]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.2.0...v0.3.0-beta001
[0.2.0]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.1.1...v0.2.0
[0.1.1]: https://github.com/TheAngryByrd/IcedTasks/compare/v0.1.0...v0.1.1
[0.1.0]: https://github.com/TheAngryByrd/IcedTasks/releases/tag/v0.1.0
[0.1.0-beta004]: https://github.com/TheAngryByrd/IcedTasks/releases/tag/v0.1.0-beta004
[0.1.0-beta003]: https://github.com/TheAngryByrd/IcedTasks/releases/tag/v0.1.0-beta003
[0.1.0-beta002]: https://github.com/TheAngryByrd/IcedTasks/releases/tag/v0.1.0-beta002
[0.1.0-beta001]: https://github.com/TheAngryByrd/IcedTasks/releases/tag/v0.1.0-beta001
