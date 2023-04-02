module P5Reference.Events.PWinMouseX

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.DOM
open P5.Events

let setup p5 =
    let canvas = createCanvasAndReturn p5 100 100
    noStroke p5
    fill p5 (RGB(237, 34, 93))

    unbox<P5Element<'Unit>> canvas

let draw p5 (canvas: P5Element<'Unit>) =
    clear p5
    let speed = abs (winMouseX p5 - pwinMouseX p5)
    ellipse p5 50 50 (10.0 + speed * 5.0) (10.0 + speed * 5.0)
    canvas.setPosition (winMouseX p5 + 1.0) (winMouseY p5 + 1.0)

let run node = simulate node setup noUpdate draw
