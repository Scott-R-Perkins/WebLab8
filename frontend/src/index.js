import { ChakraProvider } from '@chakra-ui/react';
import React, { StrictMode } from 'react';
import * as ReactDOM from 'react-dom/client';
import reportWebVitals from './reportWebVitals';
import * as serviceWorker from './serviceWorker';
import { } from "@chakra-ui/react";
import { createBrowserRouter, Outlet, RouterProvider } from 'react-router-dom';
import { Home } from './Components/pages/Home';
import { Login } from './Components/pages/Login'
import { Register } from './Components/pages/Register';
import { default as ShopAdmin } from './Components/pages/ShopAdmin';
import { default as Store } from './Components/pages/Store';
import { Layout } from './Components/layout/Layout';
import { AuthLoader } from './Components/layout/AuthLoader';

const container = document.getElementById('root');
const root = ReactDOM.createRoot(container);


const router = createBrowserRouter([
  {
    path: '',
    element: <Layout />,
    children: [
      {
        path: '',
        element: <Outlet />,
        loader: AuthLoader,
        children: [
          {
            path: '',
            element: <Home />
          },
          {
            path: 'store',
            element: <Store />
          },
          {
            path: 'admin',
            element: <ShopAdmin/>
          }
        ]
      },
      {
        path: 'login',
        element: <Login />
      },
      {
        path: 'register',
        element: <Register />
      }
    ]
  }
])

root.render(
  <StrictMode>
    <ChakraProvider>
      <RouterProvider router={router} />
    </ChakraProvider>
  </StrictMode>
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://cra.link/PWA
serviceWorker.unregister();

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
