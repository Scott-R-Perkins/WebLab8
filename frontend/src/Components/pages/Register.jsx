import { Box, Button, Input, Heading } from '@chakra-ui/react'
import React, { useState, useRef } from 'react'
import { useNavigate } from 'react-router-dom';

export const Register = () => {
    const navigate = useNavigate();

    const userEmail = useRef();
    const userPassword = useRef();

    const HandleLogin = () => {
        const registerData = {
            email: userEmail,
            password: userPassword
        }

        fetch(`${process.env.REACT_APP_BACKEND_URL}/Auth/Register`, {
            // TODO: Need to create a backend endpoint for Register
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(registerData),
        })
        navigate("/login");
    }

    return (
        <Box>
            <Heading>Register</Heading>
            <Input ref={userEmail} type={'email'} placeholder='Please enter your email' />
            <Input ref={userPassword} type={'password'} placeholder='Please enter your password' />
            <Button onClick={HandleLogin}>Register</Button>
        </Box>
    )
}

