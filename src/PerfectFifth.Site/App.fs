module P5Site

open Browser.Dom
open P5.Core

let runReference name canvasSelector =
    P5Reference.App.runSketch name canvasSelector

let runExample name = P5Examples.App.runSketch name
