module P5Reference.DOM.CreateA

open P5.Core
open P5.DOM

let draw p5 =
    let a = createA p5 "http://p5js.org/" "this is a link"
    a.setPosition 0 0

let run node = display node draw
