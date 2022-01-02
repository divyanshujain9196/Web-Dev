<?php
   if( $_GET["name"] || $_GET["Address"]|| $_GET["Phone"] ) {
      echo "Name is ". $_GET['name']. "<br />";
      echo "Address is ". $_GET['Address']. "<br/>";
      echo "phone No. is ". $_GET['Phone'];
      
      exit();
   }
?>