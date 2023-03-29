module P5Reference.Rendering.DrawingContext

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering

let draw p5 =
    let ctx = drawingContext p5

    console.log ctx

    ctx.shadowOffsetX <- 5
    ctx.shadowOffsetY <- -5
    ctx.shadowBlur <- 10
    ctx.shadowColor <- "black"

    background p5 (Grayscale 200)
    ellipse p5 (width p5 / 2 |> float) (height p5 / 2 |> float) 50 50

let run node = display node draw
