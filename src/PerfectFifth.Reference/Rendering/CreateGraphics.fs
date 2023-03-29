module P5Reference.Rendering.CreateGraphics

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.Image

let draw p5 =
    createCanvas p5 100 100
    let pg = createGraphics p5 100 100

    background p5 (Grayscale 200)
    background pg (Grayscale 100)
    noStroke pg
    ellipse pg (width pg / 2 |> float) (height pg / 2 |> float) 50 50
    image p5 pg 50 50
    imageWithSize p5 pg 0 0 50 50

let run node = display node draw
