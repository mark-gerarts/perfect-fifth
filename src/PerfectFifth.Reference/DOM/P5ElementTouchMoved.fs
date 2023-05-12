module P5Reference.DOM.P5ElementTouchMoved

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM
open P5.Math

let mutable g = 10.0

let changeGray p5 _ =
    let randomGrayscale = randomInRange p5 0 255 |> round
    g <- randomGrayscale

let setup p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    cnv'.touchMoved changeGray

let draw p5 d = background p5 (Grayscale g)

let run node = animate node setup draw
