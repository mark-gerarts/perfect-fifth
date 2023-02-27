namespace P5

module Core =

    open System
    open Fable.Core
    open Browser.Dom

    /// The methods on this class are for internal use only. You pass an
    /// instance to all functions, but never call a method on it.
    [<ImportAll("p5")>]
    type P5(sketch: Func<obj, Unit>, ?node: Browser.Types.Element) =
        member _.setup
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.draw
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.mouseMoved
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.mousePressed
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

    type Event =
        // @todo: legit event classes instead of dummy objects.
        | MouseMoved of obj
        | MousePressed of obj

    type Node =
        | Selector of string
        | Element of Browser.Types.Element
        | None

    type Sketch<'a> =
        { setup: P5 -> 'a
          update: P5 -> 'a -> 'a
          draw: P5 -> 'a -> Unit
          eventHandler: P5 -> Event -> 'a -> 'a
          node: Node }

    /// Disables the draw function from being called continuously. This should
    /// belong in P5.Structure, but because we need this in `display`, we would
    /// run into dependency issues.
    [<Emit("$0.noLoop()")>]
    let noLoop (p5: P5) : Unit = jsNative

    /// Returns the time in milliseconds since the start of the sketch. This
    /// should belong in P5.Time, but because we need this in `animate`, we
    /// would run into dependency issues.
    [<Emit("$0.millis()")>]
    let millis (p5: P5) : int = jsNative

    let defaultSketch setup =
        { setup = setup
          update = (fun _ -> id)
          draw = (fun _ _ -> ())
          eventHandler = (fun _ _ -> id)
          node = None }


    [<Global>]
    let console: JS.Console = jsNative

    let createSketch (sketch: Sketch<'a>) : Unit =
        let nodeElement =
            match sketch.node with
            | Selector selector -> document.querySelector (selector)
            | Element element -> element
            | None -> null

        let p5Sketch =
            // Inspired by https://github.com/aolney/fable-p5-demo
            new Func<obj, unit>(fun boxedP5 ->
                let mutable state = Unchecked.defaultof<'a>
                let p5 = unbox<P5> boxedP5

                // For testing purposes, delete this later.
                console.log p5

                p5.setup <- fun () -> state <- sketch.setup p5

                p5.draw <-
                    fun () ->
                        state <- sketch.update p5 state
                        sketch.draw p5 state

                p5.mouseMoved <- fun ev -> state <- sketch.eventHandler p5 (MouseMoved ev) state

                p5.mousePressed <- fun ev -> state <- sketch.eventHandler p5 (MousePressed ev) state

                ())

        new P5(p5Sketch, nodeElement) |> ignore

        ()

    let noSetup (_: P5) = ()

    /// Create a static sketch.
    let display (node: Node) (draw: P5 -> Unit) : Unit =
        let setupWithLoopDisabled (p5: P5) =
            noLoop p5
            ()

        let drawDropState (p5: P5) _ = draw p5

        createSketch
            { defaultSketch setupWithLoopDisabled with
                draw = drawDropState
                node = node }

    /// Create a simple animation sketch, which draws something based on the
    /// time elapsed.
    let animate (node: Node) (setup: P5 -> Unit) (draw: P5 -> int -> Unit) : Unit =
        let setupWithoutState p5 =
            setup p5
            ()

        let drawWithTimeElapsed (p5: P5) _ = draw p5 (millis p5)

        createSketch
            { defaultSketch setupWithoutState with
                draw = drawWithTimeElapsed
                node = node }

    /// Create a simulation sketch. It starts with an initial state, which gets
    /// updated every step.
    let simulate (node: Node) (setup: P5 -> 'a) (update: P5 -> 'a -> 'a) (draw: P5 -> 'a -> Unit) : Unit =
        createSketch
            { defaultSketch setup with
                update = update
                draw = draw
                node = node }

    /// Create a sketch with all functionality: handling state and events.
    let play
        (node: Node)
        (setup: P5 -> 'a)
        (update: P5 -> 'a -> 'a)
        (draw: P5 -> 'a -> Unit)
        (eventHandler: P5 -> Event -> 'a -> 'a)
        : Unit =
        createSketch
            { setup = setup
              update = update
              draw = draw
              eventHandler = eventHandler
              node = node }
