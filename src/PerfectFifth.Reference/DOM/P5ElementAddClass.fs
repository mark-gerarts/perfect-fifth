module P5Reference.DOM.P5ElementAddClass

open P5.Core
open P5.DOM

let draw p5 =
    let div = createDiv p5 "div"
    div.addClass "myClass"

let run node = display node draw
