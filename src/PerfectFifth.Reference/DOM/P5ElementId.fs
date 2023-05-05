module P5Reference.DOM.P5ElementId

open P5.Core
open P5.Rendering
open P5.DOM

let draw p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    // Assigns a CSS selector ID to the canvas element.
    cnv'.setId "mycanvas"

let run node = display node draw
