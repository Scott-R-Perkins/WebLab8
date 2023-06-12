import { ChakraProvider } from '@chakra-ui/react';
import React, { StrictMode } from 'react';
import * as ReactDOM from 'react-dom/client';
import reportWebVitals from './reportWebVitals';
import * as serviceWorker from './serviceWorker';
import { } from "@chakra-ui/react";
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import { Root } from './Components/Root'
import { Home } from './Components/Home';
import { default as ShopAdmin } from './Components/ShopAdmin';
import { default as Store } from './Components/Store';

const container = document.getElementById('root');
const root = ReactDOM.createRoot(container);

const router = createBrowserRouter([
  {
    path: '',
    element: <Root />,
    children:[
      {
        path: '',
        element: <Home />
      },
      {
        path: '/store',
        element: <Store />
      },
      {
        path: '/admin',
        element: <ShopAdmin />
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
