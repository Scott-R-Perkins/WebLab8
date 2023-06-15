import { Button, HStack } from '@chakra-ui/react'
import React from 'react'
import { Link, useNavigate } from 'react-router-dom'

const routes = [
  {
    path:'',
    display: 'Home',
  },
  {
    path: 'store',
    display: 'Store',
  },
  {
    path: 'admin',
    display: 'Admin',
  },
  {
    path: 'register',
    display: 'Register',
  },
  {
    path: 'login',
    display: 'Login',
  },
]

export const Navbar = () => {

  const navigate = useNavigate();

  const handleLogout = () =>{
    sessionStorage.removeItem('token')
    navigate('/login')
  };

  return (
    <div>
      <HStack mb={10}>
        {routes.map(route => <Link to={route.path} key={route.display}>{route.display}</Link>)}
        <Button onClick={handleLogout}>Logout</Button>
      </HStack>
    </div>
  )
}
