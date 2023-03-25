module P5Reference.Structure.Subscriptions

open P5.Core
open P5.Shape
open P5.Color
open Browser.Types
open P5.Typography

type Shape =
    | Square
    | Circle

type State = { counter: int; shape: Shape }

let setup p5 = { counter = 0; shape = Circle }

let update p5 state =
    { state with counter = state.counter + 1 }

// Draw something based on the current state.
let draw p5 state =
    background p5 (Grayscale 51)

    match state.shape with
    | Circle -> circle p5 50 50 50
    | Square -> square p5 25 25 50

    text p5 (string state.counter) 40 15

// Alternate between square and circle when mouse is pressed. This is an event
// handler that updates the state.
let onMouseClicked p5 event state =
    let shape =
        match state.shape with
        | Circle -> Square
        | Square -> Circle

    { state with shape = shape }

// Multiple event handlers of the same type are perfectly possible. This one
// does not transform the state, and only has a side effect.
let onMouseClickedEff p5 event =
    let rand = System.Random()
    let r = rand.Next(0, 255)
    let g = rand.Next(0, 255)
    let b = rand.Next(0, 255)

    fill p5 (RGB(r, g, b))

// Event handlers get passed their respective JavaScript events (e.g.
// MouseEvent, UIEvent, ...).
let onMouseMoved p5 (event: MouseEvent) = printfn "%A" event.clientX

let subscriptions =
    [ OnMouseClicked(Update onMouseClicked)
      OnMouseClicked(Effect onMouseClickedEff)
      OnMouseMoved(Effect onMouseMoved) ]

let run node =
    play node setup update draw subscriptions
