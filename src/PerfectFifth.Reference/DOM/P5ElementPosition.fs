module P5Reference.DOM.P5ElementPosition

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.DOM
open P5.Rendering

let setup p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv

    // positions canvas 50px to the right and 100px
    // below upper left corner of the window
    cnv'.setPosition 50 100

    cnv'.setPositionWithType 0 0 Fixed

let draw p5 _ = ()

let run node = animate node setup draw
