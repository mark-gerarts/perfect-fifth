namespace P5

module Core =

    open Fable.Core

    type P5 =
        class
        end

    type Event = MouseMoved

    type Initial<'a> = 'a

    type Setup = P5 -> Unit

    type Update<'a> = P5 -> 'a -> 'a

    type Draw<'a> = P5 -> 'a -> Unit

    type EventHandler<'a> = P5 -> Event -> 'a -> 'a

    // @todo: element
    type Node =
        | Selector of string
        | Element of string
        | None

    // Inspired by Quil's fun-mode and Gloss.
    type Sketch<'a> =
        { initial: Initial<'a>
          setup: Setup
          update: Update<'a>
          draw: Draw<'a>
          eventHandler: EventHandler<'a>
          node: Node }

    let defaultSketch initial =
        { initial = initial
          setup = (fun _ -> ())
          update = (fun _ -> id)
          draw = (fun _ _ -> ())
          eventHandler = (fun _ _ -> id)
          node = None }

    // TODO: display / animate / simulate / play
    [<ImportMember("./sketch.js")>]
    let createSketch (sketch: Sketch<'a>) = jsNative

    let noSetup (_: P5) = ()

    let display (setup: Setup) (draw: P5 -> Unit) =
        let statefulDraw (p5: P5) _ = draw p5

        createSketch
            { defaultSketch () with
                setup = setup
                draw = statefulDraw }
