import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';

import ParticlesBg from "particles-bg";
import { LoginMenu } from '../api-authorization/LoginMenu';

export class Header extends Component {
  render() {

    if(this.props.data){
       var project = this.props.data.project;
       var github = this.props.data.github;
      var name = this.props.data.name;
      var description= this.props.data.description;
      var city= this.props.data.address.city;
      var networks= this.props.data.social.map(function(network){
        return <li key={network.name}><a href={network.url}><i className={network.className}></i></a></li>
      })
    }

    return (
      <header id="home">
      <ParticlesBg type="circle" bg={true} />
      <nav id="nav-wrap">
         <a className="mobile-btn" href="#nav-wrap" title="Show navigation">Show navigation</a>
	      <a className="mobile-btn" href="#home" title="Hide navigation">Hide navigation</a>

         <ul id="nav" className="nav">
           
                    <NavItem className= "current">
                        <NavLink className="smoothscroll" href="#home">Home</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink className="smoothscroll" href="#about">About</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink className="smoothscroll" href="#resume">Resume</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink className="smoothscroll" href="#portfolio">Works</NavLink>
                    </NavItem>
                            <NavItem>
                        <NavLink className="smoothscroll" href="#contact">Contact</NavLink>
                    </NavItem>
                    <LoginMenu>
                    </LoginMenu>
                     
         </ul>
      </nav>

      <div className="row banner">
      
         <div className="banner-text">
            <h1 className="responsive-headline">{name}</h1>
            <h3>{description}.</h3>
            <hr />
            <ul className="social">
               <a href={project} className="button btn project-btn"><i className="fa fa-book"></i>Project</a>
               <a href={github} className="button btn github-btn"><i className="fa fa-github"></i>Github</a>
            </ul>
         </div>
      </div>

      <p className="scrolldown">
         <a className="smoothscroll" href="#about"><i className="icon-down-circle"></i></a>
      </p>

   </header>
    );
  }
}


