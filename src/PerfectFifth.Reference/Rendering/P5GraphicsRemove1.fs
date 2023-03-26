module P5Reference.Rendering.P5GraphicsRemove1

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Image
open P5.Math

let setup p5 =
    setPixelDensity p5 1
    createCanvas p5 100 100
    stroke p5 (Grayscale 255)
    fill p5 (Grayscale 0)

    let bg = createGraphics p5 100 100
    background bg (Grayscale 100)
    ellipse bg 50 50 80 80

    Some bg

let draw p5 bg =
    let t = ((millis p5 |> float) / 1000.0)
    let frameCount = frameCount p5 % 100 |> float

    match bg with
    | Some bg ->
        image p5 bg (frameCount) 0
        image p5 bg (frameCount - 100.0) 0
    | None -> ()

    let p = P5Vector.fromAngleAndLength t 35
    p.addXY 50 50

    circle p5 p.x p.y 30

let onMouseClicked p5 ev (bg: P5 option) =
    match bg with
    | Some bg ->
        bg.remove ()
        None
    | None -> None

let subscriptions = [ OnMouseClicked(Update onMouseClicked) ]

let run node =
    play node setup noUpdate draw subscriptions
