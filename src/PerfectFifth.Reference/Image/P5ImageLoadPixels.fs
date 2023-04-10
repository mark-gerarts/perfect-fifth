module P5Reference.Image.P5ImageLoadPixels

open P5.Core
open P5.Environment
open P5.Image

let preload p5 = loadImage p5 "assets/rockies.jpg"

let draw p5 (img: P5Image) =
    img.loadPixels ()
    let halfImage = 4 * img.width * img.height / 2

    for i in { 0 .. halfImage - 1 } do
        img.pixels[i + halfImage] <- img.pixels[i]

    img.updatePixels ()

    imageWithSize p5 img 0 0 (width p5) (height p5)

let run node = displayWithPreload node preload draw
