module P5Reference.DOM.P5MediaElementLoop

open P5.Core
open P5.Color
open P5.Environment
open P5.Typography
open P5.DOM
open P5.Events

type State =
    { ele: P5MediaElement; isLooping: bool }

let setup p5 =
    let ele = createAudio p5 "assets/beat.mp3"

    background p5 (Grayscale 200)
    setTextAlign p5 centerTextAlign
    text p5 "Click to loop!" (width p5 / 2 |> float) (height p5 / 2 |> float)

    { ele = ele; isLooping = false }


let draw _ _ = ()

let onMouseClicked p5 _ (state: State) =
    let mouseX = mouseX p5
    let mouseY = mouseY p5
    let width = width p5
    let height = height p5

    if (mouseX >= 0 && mouseX <= width && mouseY >= 0 && mouseY <= height) then
        background p5 (Grayscale 200)

        if not state.isLooping then
            state.ele.loop ()
            text p5 "Click to stop!" (width / 2 |> float) (height / 2 |> float)

            { state with isLooping = true }
        else
            state.ele.stop ()
            text p5 "Click to loop!" (width / 2 |> float) (height / 2 |> float)

            { state with isLooping = false }
    else
        state

let run node =
    play node setup noUpdate draw [ OnMouseClicked(Update onMouseClicked) ]
