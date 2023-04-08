module P5Reference.Image.P5ImageCopy

open P5.Core
open P5.Image

type State = { photo: P5Image; bricks: P5Image }

let preload p5 =
    let photo = loadImage p5 "assets/rockies.jpg"
    let bricks = loadImage p5 "assets/bricks.jpg"
    { photo = photo; bricks = bricks }

let draw p5 state =
    let x = state.bricks.width / 2
    let y = state.bricks.height / 2
    state.photo.copyFrom state.bricks 0 0 x y 0 0 x y
    image p5 state.photo 0 0

let run node = displayWithPreload node preload draw
