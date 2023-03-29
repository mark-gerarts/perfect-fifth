module P5Reference.Rendering.ResizeCanvas

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering

let getCanvasSize p5 =
    // Fullscreen as in the original example is a bit much.
    (windowWidth p5 / 10, windowHeight p5 / 5)

let setup p5 =
    let (w, h) = getCanvasSize p5
    createCanvas p5 w h

let draw p5 _ = background p5 (RGB(0, 100, 200))

let onWindowResized p5 _ =
    let (w, h) = getCanvasSize p5
    resizeCanvas p5 w h

let subscriptions = [ OnWindowResized(Effect onWindowResized) ]

let run node =
    play node setup noUpdate draw subscriptions
