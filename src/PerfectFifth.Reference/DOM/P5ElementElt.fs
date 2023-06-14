module P5Reference.DOM.P5ElementElt

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM
open Fable.Core.JsInterop

let draw p5 =
    let c = createCanvasAndReturn p5 50 50
    // Due to an implementation detail, createCanvas returns a P5 instance.
    let c' = unbox<P5Element<Unit>> c
    c'.elt?style?border <- "5px solid red"

    background p5 (Grayscale 220)

let run node = display node draw
