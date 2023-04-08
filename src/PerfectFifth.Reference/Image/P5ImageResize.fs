module P5Reference.Image.P5ImageResize

open P5.Core
open P5.Image

let preload p5 = loadImage p5 "assets/rockies.jpg"

let setup _ = id

let draw p5 (img: P5Image) = image p5 img 0 0

let onMousePressed _ _ (img: P5Image) =
    img.resize 50 100
    img

let subscriptions = [ OnMousePressed(Update onMousePressed) ]

let run node =
    playWithPreload node preload setup noUpdate draw subscriptions
