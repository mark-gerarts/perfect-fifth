module P5Reference.DOM.CreateImg

open P5.Core
open P5.DOM

let draw p5 =
    let img =
        createImg p5 "https://p5js.org/assets/img/asterisk-01.png" "the p5 magenta asterisk"

    img.setPosition 0 -10

let run node = display node draw
