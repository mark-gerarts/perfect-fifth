module P5Reference.Math.Log

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math
open P5.Data
open P5.Typography
open P5.Events

let draw p5 _ =
    let mouseX = mouseX p5
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 200)
    let maxX = 2.8
    let maxY = 1.5

    // Draw the log(x) curve,
    // over the domain of x from 0 to maxX
    noFill p5
    stroke p5 (Grayscale 0)

    beginShape p5

    for x in { 0.0 .. width } do
        let xValue = map p5 x 0 width 0 maxX
        let yValue = log xValue
        let y = map p5 yValue -maxY maxY height 0
        vertex p5 x y

    endShape p5

    line p5 0 0 0 height
    line p5 0 (height / 2.0) width (height / 2.0)

    // Compute the natural log of a value between 0 and maxX
    let xValue = map p5 mouseX 0 width 0 maxX

    if xValue > 0 then
        do
            // Cannot take the log of a negative number.
            let yValue = log xValue
            let y = map p5 yValue -maxY maxY height 0

            // Display the calculation occurring.
            let legend =
                "log("
                + (nfWithPrecision p5 xValue 1 2)
                + ")\n= "
                + (nfWithPrecision p5 yValue 1 3)

            stroke p5 (Grayscale 150)
            line p5 mouseX y mouseX height
            fill p5 (Grayscale 0)
            text p5 legend 5 15
            noStroke p5
            circle p5 mouseX y 7

let run node = animate node noSetup draw
