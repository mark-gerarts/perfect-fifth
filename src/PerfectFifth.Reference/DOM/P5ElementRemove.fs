module P5Reference.DOM.P5ElementRemove

open P5.Core
open P5.DOM

let draw p5 =
    let myDiv = createDiv p5 "this is some text"
    myDiv.remove ()

let run node = display node draw
