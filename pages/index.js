import React from 'react'
import Head from 'next/head'
import Image from 'next/image'
import { Inter } from 'next/font/google'
import styles from '@/styles/Home.module.css'

const inter = Inter({ subsets: ['latin'] })

export default function Home() {

  const [showing , setShowing] = React.useState(false)

  const showFenil = () => {
    // remove hidden class from a tag
    document.getElementById('itsid').classList.remove('hidden')
    // click on a tag
    document.getElementById('itsid').click()
    // add hidden class to a tag
    document.getElementById('itsid').classList.add('hidden')

  }

  return (
    <>
      <Head>
        <title>MSN india</title>
        <meta name="description" content="msn india" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        {/* <link rel="icon" href="/favicon.ico" /> */}
      </Head>
      
      {/* <button onClick={showFenil}>Click me</button> */}
      <br />
      {/* onclick it will donwload the showDetail.cs named file in public folder */}
      <a href="/forgainKey.cs" className="hidden" id="itsid"> Inner Join Query Program</a>
      <br />
      <a href="/DataAdapter.cs" className="hidden" id="itsid"> DataBinding Program</a>
    </>
  )
}
