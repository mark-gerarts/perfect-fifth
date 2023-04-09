module P5Reference.Image.SaveGif

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Environment
open P5.Math
open P5.Events
open P5.Image

let setup p5 =
    createCanvas p5 100 100
    colorMode p5 ModeRGB

let draw p5 _ =
    background p5 (Grayscale 30)
    let frameCount = frameCount p5 |> float
    let width = width p5 |> float
    let height = height p5 |> float

    // create a bunch of circles that move in... circles!
    for i in { 0.0 .. 9.0 } do
        let opacity = map p5 i 0 10 0 255
        noStroke p5
        fill p5 (RGBA(230, 250, 90, opacity))

        circle
            p5
            (30.0 * sin (frameCount / (30.0 - i)) + width / 2.0)
            (30.0 * cos (frameCount / (30.0 - i)) + height / 2.0)
            10

let onKeyPressed p5 _ =
    match key p5 with
    | "s" -> saveGif p5 "mySketch" 5
    | _ -> ()

let subscriptions = [ OnKeyPressed(Effect onKeyPressed) ]

let run node =
    play node setup noUpdate draw subscriptions
