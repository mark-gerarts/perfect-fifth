module P5Reference.DOM.P5ElementRemoveClass

open P5.Core
open P5.DOM

let setup p5 =
    let div = createDiv p5 "div"
    div.addClass "myClass"
    div

let draw _ _ = ()

let onMousePressed _ _ (div: P5Element<Unit>) =
    div.removeClass "myClass"
    div

let subscriptions = [ OnMousePressed(Update onMousePressed) ]

let run node =
    play node setup noUpdate draw subscriptions
