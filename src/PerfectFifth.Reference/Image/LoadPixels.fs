module P5Reference.Image.LoadPixels

open P5.Core
open P5.Environment
open P5.Image

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 img =
    let width = width p5
    let height = height p5

    imageWithSize p5 img 0 0 (float width) (float height)
    let d = pixelDensity p5 |> int
    let halfImage = 4 * (width * d) * (height * d / 2)
    loadPixels p5
    let pixels = pixels p5

    for i in { 0 .. halfImage - 1 } do
        pixels[i + halfImage] <- pixels[i]

    updatePixels p5

let run node = displayWithPreload node preload draw
