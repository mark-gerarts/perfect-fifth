module P5Reference.DOM.P5ElementChild

open P5.Core
open P5.DOM
open Browser

let draw p5 =
    let div0 = createDiv p5 "this is the parent"
    let div1 = createDiv p5 "this is the child"
    // This needs some hacky workaround for now...
    let selector = P5El div1 |> unbox<Selector<obj>>
    div0.getChildBySelector selector |> ignore // use p5.Element

    div1.setId "apples"
    div0.getChildBySelector (Id "apples") |> ignore // use id


    let elt = document.getElementById "myChildDiv"
    div0.getChildBySelector (HTMLEl elt) |> ignore // use element from page

let run node = display node draw
