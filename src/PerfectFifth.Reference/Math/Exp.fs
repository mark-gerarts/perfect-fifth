module P5Reference.Math.Exp

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events
open P5.Math
open P5.Data
open P5.Typography

let draw p5 _ =
    let mouseX = mouseX p5
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 200)

    // Compute the exp() function with a value between 0 and 2
    let xValue = map p5 mouseX 0 width 0 2
    let yValue = exp xValue

    let y = map p5 yValue 0 8 height 0

    let legend =
        "exp ("
        + (nfcWithPrecision p5 xValue 3)
        + ")\n= "
        + (nfWithPrecision p5 yValue 1 4)

    stroke p5 (Grayscale 150)
    line p5 mouseX y mouseX height
    fill p5 (Grayscale 0)
    text p5 legend 5 15
    noStroke p5
    circle p5 mouseX y 7

    // Draw the exp(x) curve,
    // over the domain of x from 0 to 2
    noFill p5
    stroke p5 (Grayscale 0)
    beginShape p5

    for x in { 0.0 .. width - 1.0 } do
        let xValue = map p5 x 0 width 0 2
        let yValue = exp xValue
        let y = map p5 yValue 0 8 height 0
        vertex p5 x y

    endShape p5
    line p5 0 0 0 height
    line p5 0 (height - 1.0) width (height - 1.0)

let run node = animate node noSetup draw
