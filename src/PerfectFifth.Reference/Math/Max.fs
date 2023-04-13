module P5Reference.Math.Max

open P5.Core
open P5.Color
open P5.Typography

let draw p5 =
    let numArray = [ 2; 1; 5; 4; 8; 9 ]
    fill p5 (Grayscale 0)
    noStroke p5

    text p5 "Array Elements" 0 10

    // Draw all numbers in the array
    let spacing = 15.0
    let elemsY = 25

    numArray |> Seq.iteri (fun i x -> text p5 (string x) (float i * spacing) elemsY)

    let maxX = 33
    let maxY = 80
    // Draw the maximum value in the array.
    setTextSize p5 32
    text p5 (numArray |> Seq.max |> string) maxX maxY

let run node = display node draw
