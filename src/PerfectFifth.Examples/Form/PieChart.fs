module P5Examples.Form.PieChart

open P5.Core
open P5.Rendering
open P5.Color
open P5.Shape
open P5.Environment
open P5.Math

let angles = [ 30; 10; 45; 35; 60; 38; 75; 67 ]

let pieChart p5 diameter data =
    // Literal, non-functional translation.
    // TODO: improve this.
    let mutable lastAngle = 0.0
    let width = width p5 |> float
    let height = height p5 |> float

    for (i, dataPoint) in (List.indexed data) do
        map p5 i 0 (List.length data) 0 255 |> Grayscale |> fill p5
        arc p5 (width / 2.0) (height / 2.0) diameter diameter lastAngle (lastAngle + radians p5 dataPoint)
        lastAngle <- lastAngle + radians p5 dataPoint

let draw p5 =
    resizeCanvas p5 720 400
    noStroke p5
    background p5 (Grayscale 100)
    pieChart p5 300 (List.map float angles)

let run node = display node draw
