module P5Reference.DOM.P5ElementParent

open P5.Core
open P5.Rendering
open P5.DOM

let draw p5 =
    let cnv = createCanvasAndReturn p5 100 100
    let cnv' = unbox<P5Element<Unit>> cnv
    cnv'.getParentBySelector (Id "myContainer") |> ignore

    let div0 = createDiv p5 "this is the parent"
    let div1 = createDiv p5 "this is the child"
    div1.getParentBySelector (P5El div0) |> ignore // use p5.Element

    let div0' = createDiv p5 "this is the parent"
    div0'.setId "apples"
    let div1' = createDiv p5 "this is the child"
    div1'.getParentBySelector (Id "apples") |> ignore // use id

    let elt = Browser.Dom.document.getElementById "myContainer"
    let div1 = createDiv p5 "this is the child"
    div1.getParentBySelector (HTMLEl elt) |> ignore // use element from page

let run node = display node draw
