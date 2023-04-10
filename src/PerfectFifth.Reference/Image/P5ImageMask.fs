module P5Reference.Image.P5ImageMask

open P5.Core
open P5.Image
open P5.Rendering

type State = { photo: P5Image; mask: P5Image }

let preload p5 =
    let photo = loadImage p5 "assets/rockies.jpg"
    let mask = loadImage p5 "assets/mask2.png"
    { photo = photo; mask = mask }

let draw p5 state =
    createCanvas p5 100 100
    state.photo.mask state.mask
    image p5 state.photo 0 0

let run node = displayWithPreload node preload draw
