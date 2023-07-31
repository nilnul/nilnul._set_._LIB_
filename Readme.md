# `nilnul._set_._LIB_`
(codename: nilnul.\_set_.\_LIB_)

Set theory, a knowledge represented in code.

This library is on finite set. The definition of infinite set is deferred to a later projects called `nilnul.collection` or the like.

An element can be in the set or not. If an element is in the set, it's insignificant how many times it reappears.
The order of the elements of a set is insignificant.

## development

The unit testing project is placed in another repo `nilnul._set_._TEST_`. To develop, clone this repo and the testing repo into  a same parent folder which can be named as `nilnul._set_\`, and this repo as the subdirectory can be named `_LIB_\`, and the test project `_TEST_\`.

You can try some of library code, or check some of your own ideas using this library in the test project instead of creating each console application for each trial. The trial code can be marked by preprocessor instructions such as `#if TRIAL` in order to not participate the run of unit testing .

The compiled package is pushed to nuget.org. Currently the testing hasnot covered all code paths, so the package is in pre-release mode. Be sure to "include prerelease" before searching for it. You can help write more testing code to make it exhaustive, and we can then published the package in release mode.


## some highlights

### expression
Expression of set is recursively defined starting with `nilnul.set.expr_.Var`. We defined minter, and canonical Sop(sum of product) form of expressions; any expression can be transformed to canonical form and then determined whether they are equal. See in unit test for some example.

### abgebra
Abstract algebra cannot be defined solidly without a solid foundation of set theory. But some terms in abstract algebra (or abgebra as nilnul systems would call it - note it's a'b'gebra, not a'l'gebra) would mean some subtly different things in different literature. To avoid the ambiguity, some terms are defined using code here.

## coding style

The coding style follows a prototype embodied by other nilnul projects. This nilnul style is later formalized in `nilnul._dev_` project, which is being in another development process.




