import { Box, Button, Input, Heading } from '@chakra-ui/react'
import React, { useState, useRef } from 'react'
import { useNavigate } from 'react-router-dom';

export const Login = () => {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [token, setToken] = useState('');
    const navigate = useNavigate();

    const userEmail = useRef();
    const userPassword = useRef();
  
    const HandleLogin = () => {
        const loginData = {
            email: userEmail.current.value,
            password: userPassword.current.value
        }
        
  
      fetch(`${process.env.REACT_APP_BACKEND_URL}/Auth/Login`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        //Need to use JSON.stringify(loginData) rather than just body: loginData as the backend is C# and can't interpret the object via js 
        body: JSON.stringify(loginData),
      })
        .then(response => response.json())
        .then(body => {
          if (body.token) {
            //Can check if users token matches one in session storage, if its not there redirect them back to login page.
            sessionStorage.setItem("token", body.token)
            setToken(body.token);
            navigate("/store");
          }
          else { 
            console.log(body.errorMessage); 
          }
        })
        .then(() => console.log(token))
        .catch(err => console.log(err))
    }
  
    return (
      <Box>
        <Heading>Login page</Heading>
        <Input ref={userEmail} type={'email'} placeholder='Please enter your email' />
        <Input ref={userPassword} type={'password'} placeholder='Please enter your password' />
        <Button onClick={HandleLogin}>Login</Button>
      </Box>
    )
  }
