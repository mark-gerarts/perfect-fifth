module P5Reference.Image.CreateImage2

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Image

let draw p5 =
    let pink = RGB(255, 102, 204)
    let img = createImage p5 66 66
    img.loadPixels ()
    let d = pixelDensity p5 |> int
    let halfImage = 4 * (img.width * d) * (img.height / 2 * d)


    console.log (red p5 pink)
    console.log (green p5 pink)
    console.log (blue p5 pink)

    for i in seq { 0..4 .. (halfImage - 1) } do
        img.pixels[i] <- red p5 pink
        img.pixels[i + 1] <- green p5 pink
        img.pixels[i + 2] <- blue p5 pink
        img.pixels[i + 3] <- alpha p5 pink

    img.updatePixels ()
    image p5 img 17 17

let run node = display node draw
