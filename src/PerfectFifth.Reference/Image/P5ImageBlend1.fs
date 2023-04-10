module P5Reference.Image.P5ImageBlend1

open P5.Core
open P5.Rendering
open P5.Image

let preload p5 =
    let mountains = loadImage p5 "assets/rockies.jpg"
    let bricks = loadImage p5 "assets/bricks_third.jpg"
    (mountains, bricks)

let draw p5 (mountains: P5Image, bricks: P5Image) =
    mountains.blendFrom bricks 0 0 33 100 67 0 33 100 Darkest
    image p5 mountains 0 0
    image p5 bricks 0 0

let run node = displayWithPreload node preload draw
