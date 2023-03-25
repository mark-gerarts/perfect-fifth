module P5Reference.Structure.Remove

open P5.Core
open P5.Shape
open P5.Structure

let draw p5 _ = circle p5 50 50 10

let onMousePressed p5 _ = remove p5

let subscriptions = [ OnMousePressed(Effect onMousePressed) ]

let run node =
    play node noSetup noUpdate draw subscriptions
