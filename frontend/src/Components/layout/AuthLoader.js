import { redirect } from "react-router-dom";

export const AuthLoader = async () =>{
    const token = sessionStorage.getItem('token')
    if(!token) return redirect('/login')

    // TODO: Validate token. Make sure its not expired and its actually a token.
    return null;
}