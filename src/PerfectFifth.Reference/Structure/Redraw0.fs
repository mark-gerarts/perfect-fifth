module P5Reference.Structure.Redraw0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Structure

let setup p5 =
    noLoop p5
    0.0

let draw p5 x =
    background p5 (Grayscale 204)
    line p5 x 0 x (height p5 |> float)

let onMousePressed p5 ev x = x + 1.0

// We do the redraw in a separate subscription because we can't update the state
// and then do something *after* that in the same subscription (which is really
// only a problem for `redraw`).
let onMousePressedEff p5 ev = redraw p5

let subscriptions =
    [ OnMousePressed(Update onMousePressed)
      OnMousePressed(Effect onMousePressedEff) ]

let run node =
    play node setup noUpdate draw subscriptions
