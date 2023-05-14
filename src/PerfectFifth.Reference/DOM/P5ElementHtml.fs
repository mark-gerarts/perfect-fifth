module P5Reference.DOM.P5ElementHtml

open P5.Core
open P5.DOM

let draw p5 =
    let div = createDiv p5 ""
    div.setSize 100 100
    div.setHtml "Hello"

    div.appendHtml " World"

let run node = display node draw
