module P5Reference.DOM.P5ElementValue

open P5.Core
open P5.DOM
open P5.Environment

let setup p5 =
    let inp1 = createInputWithValue p5 ""
    let inp2 = createInputWithValue p5 "myValue"
    (inp1, inp2)

let draw _ _ = ()

let onMousePressed p5 _ (inp1: P5Element<string>, inp2: P5Element<string>) =
    print p5 (inp1.getValue ())
    inp2.setValue "myValue"
    (inp1, inp2)

let run node =
    play node setup noUpdate draw [ OnMousePressed(Update onMousePressed) ]
