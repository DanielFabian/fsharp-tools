﻿(*

Copyright 2013 Jack Pappas

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

*)

[<AutoOpen>]
module TestHelpers

open NUnit.Framework
open FsUnit


(* Fluent test helpers for use with NUnit and FsUnit. *)

/// Tests that the specified condition is true.
/// If not, calls Assert.Fail with a formatted string.
let inline assertf (condition : bool) format : 'T =
    Printf.ksprintf (fun str -> if not condition then Assert.Fail str) format

/// Asserts that two values are equal.
let inline assertEqual<'T when 'T : equality> (expected : 'T) (actual : 'T) =
    Assert.AreEqual (expected, actual)

/// Asserts that two values are NOT equal.
let inline assertNotEqual<'T when 'T : equality> (expected : 'T) (actual : 'T) =
    Assert.AreNotEqual (expected, actual)

/// Asserts that two objects are identical.
let inline assertSame<'T when 'T : not struct> (expected : 'T) (actual : 'T) =
    Assert.AreSame (expected, actual)

/// Asserts that two objects are NOT identical.
let inline assertNotSame<'T when 'T : not struct> (expected : 'T) (actual : 'T) =
    Assert.AreNotSame (expected, actual)

/// Asserts that a condition is true.
let inline assertTrue condition =
    Assert.IsTrue (condition)

/// Asserts that a condition is false.
let inline assertFalse condition =
    Assert.IsFalse (condition)
