module P5Reference.Image.P5ImageFilter

open P5.Core
open P5.Image
open P5.Environment

let preload p5 =
    let photo1 = loadImage p5 "assets/rockies.jpg"
    let photo2 = loadImage p5 "assets/rockies.jpg"
    (photo1, photo2)

let draw p5 (photo1: P5Image, photo2: P5Image) =
    photo2.filter Gray
    image p5 photo1 0 0
    image p5 photo2 (width p5 / 2 |> float) 0

let run node = displayWithPreload node preload draw
