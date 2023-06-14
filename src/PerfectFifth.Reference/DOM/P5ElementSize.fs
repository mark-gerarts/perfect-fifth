module P5Reference.DOM.P5ElementSize

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.DOM

let draw p5 =
    let div = createDiv p5 "this is a div"
    div.setSize 100 100

    createImgWithCallback p5 "assets/rockies.jpg" "A tall mountain" "" (fun img -> img.setWidth 10)
    |> ignore

let run node = display node draw
