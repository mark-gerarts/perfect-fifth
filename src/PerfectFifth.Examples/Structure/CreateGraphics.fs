module P5Examples.Structure.CreateGraphics

open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape
open P5.Events
open P5.Image

let setup p5 =
    createCanvas p5 710 400

    // Return the off-screen graphics buffer as our state.
    createGraphics p5 400 250

let update _ = id

let draw p5 pg =
    let width = width p5 |> float
    let height = height p5 |> float
    let mouseX = mouseX p5 |> float
    let mouseY = mouseY p5 |> float

    fill p5 (GrayscaleA(0, 12))
    rect p5 0 0 width height
    fill p5 (Grayscale 255)
    noStroke p5
    circle p5 mouseX mouseY 60

    background pg (Grayscale 51)
    noFill pg
    stroke pg (Grayscale 255)
    circle pg (mouseX - 150.0) (mouseY - 75.0) 60

    image p5 pg 150 75



let run node = simulate node setup update draw
