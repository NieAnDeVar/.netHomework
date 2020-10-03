// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic


let sum x y:(double) = x + y
let div x y:(double) =  x / y
let sub x y:(double) = x - y
let mult x y:(double) = x * y
let SplitStr (str:string) =
    str.Split(" ")
    

let CalculatePart1 x sign y =
    match sign with
    | "+" -> sum x y 
    | "-" ->sub x y    
    | "/" -> div x y 
    | "*" ->  mult x y
    
let Calculate str =
    let list = SplitStr str
    let x = list.[0]|> double
    let y = list.[2] |> double
    CalculatePart1 x list.[1] y


let x = Console.ReadLine() |> string
let result = Calculate x 
printf "Result: %A" result


    