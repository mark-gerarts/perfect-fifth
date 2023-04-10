module P5Reference.Image.Pixels

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Image

let draw p5 =
    let pink = (RGB(255, 102, 204))
    loadPixels p5
    let d = pixelDensity p5 |> int
    let halfImage = 4 * (width p5 * d) * (height p5 / 2 * d)
    let pixels = pixels p5

    for i in { 0..4 .. halfImage - 1 } do
        pixels[i] <- red p5 pink
        pixels[i + 1] <- green p5 pink
        pixels[i + 2] <- blue p5 pink
        pixels[i + 3] <- alpha p5 pink

    updatePixels p5

let run node = display node draw
