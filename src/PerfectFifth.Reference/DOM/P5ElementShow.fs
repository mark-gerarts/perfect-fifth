module P5Reference.DOM.P5ElementShow

open P5.Core
open P5.DOM

let draw p5 =
    let div = createDiv p5 "div"
    div.style "display" "none"
    div.show ()

let run node = display node draw
