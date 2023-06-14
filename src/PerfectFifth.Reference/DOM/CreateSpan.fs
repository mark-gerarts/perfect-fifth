module P5Reference.DOM.CreateSpan

open P5.Core
open P5.DOM

let draw p5 =
    let span = createSpan p5 "this is some text"
    span.setPosition 0 0

let run node = display node draw
