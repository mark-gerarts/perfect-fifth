module P5Reference.Environment.GetUrl

open P5.Core
open P5.Typography
open P5.Color
open P5.Environment

let setup _ = 100.0

let update _ x = x - 1.0

let draw p5 x =
    let height = height p5 |> float
    fill p5 (Grayscale 0)
    noStroke p5
    background p5 (Grayscale 200)

    let url = getURL p5
    text p5 url x (height / 2.0)

let run node = simulate node setup update draw
