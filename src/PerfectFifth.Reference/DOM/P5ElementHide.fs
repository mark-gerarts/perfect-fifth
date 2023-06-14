module P5Reference.DOM.P5ElementHide

open P5.Core
open P5.DOM

let draw p5 =
    let div = createDiv p5 "this is a div"
    div.hide ()

let run node = display node draw
