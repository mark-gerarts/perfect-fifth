module P5Reference.Math.Norm

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography
open P5.Events
open P5.Math

let draw p5 _ =
    let width = width p5 |> float

    background p5 (Grayscale 200)
    let currentNum = mouseX p5
    let lowerBound = 0
    let upperBound = width
    let normalized = norm p5 currentNum lowerBound upperBound
    let lineY = 70
    stroke p5 (Grayscale 3)
    line p5 0 lineY width lineY
    //Draw an ellipse mapped to the non-normalized value.
    noStroke p5
    fill p5 (Grayscale 50)
    let s = 7 // ellipse size
    circle p5 currentNum lineY s

    // Draw the guide
    let guideY = lineY + 15
    text p5 "0" 0 guideY

    setTextAlign
        p5
        { horizontal = Right
          vertical = Center }

    text p5 "100" width guideY

    // Draw the normalized value
    setTextAlign p5 { horizontal = Left; vertical = Center }
    fill p5 (Grayscale 0)
    setTextSize p5 32
    let normalY = 40
    let normalX = 20
    text p5 (string normalized) normalX normalY

let run node = animate node noSetup draw
