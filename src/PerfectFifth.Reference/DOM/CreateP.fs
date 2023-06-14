module P5Reference.DOM.CreateP

open P5.Core
open P5.DOM

let draw p5 =
    let p = createP p5 "this is some text"
    p.style "font-size" "16px"
    p.setPosition 10 0

let run node = display node draw
