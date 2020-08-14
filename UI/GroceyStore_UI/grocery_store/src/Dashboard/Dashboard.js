import React, { useEffect, useState } from "react";
import {
  Grid,
  Card,
  CardMedia,
  CardContent,
  Typography,
  CircularProgress,
  TextField,
} from "@material-ui/core";
import { fade, makeStyles } from "@material-ui/core/styles";
import { toFirstCharUppercase } from "../Healper";
import mockData from "../mockData";

const useStyles = makeStyles((theme) => ({
  DashboardContainer: {
    paddingTop: "20px",
    paddingLeft: "50px",
    paddingRight: "50px",
  },
  cardMedia: {
    margin: "auto",
  },
  cardContent: {
    textAlign: "center",
  },
}));

export const Dashboard = () => {
  const classes = useStyles();
  const [dashboardData, setDashboardData] = useState(mockData);

  const getCard = (catagoryId) => {
    console.log(dashboardData[`${catagoryId}`]);
    console.log("cat " + catagoryId);

    const { id, name } = dashboardData[`${catagoryId}`];
    const sprite = `https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${1}.png`;

    return (
      <Grid item xs={6} sm={4} key={catagoryId}>
        <Card>
          <CardMedia
            className={classes.cardMedia}
            image={sprite}
            style={{ width: "130px", height: "130px" }}
          />
          <CardContent className={classes.cardContent}>
            <Typography>{`${toFirstCharUppercase(name)}`}</Typography>
          </CardContent>
        </Card>
      </Grid>
    );
  };

  return (
    <div>
      {dashboardData ? (
        <Grid container spacing={2} className={classes.DashboardContainer}>
          {Object.keys(dashboardData).map((catagoryId) => getCard(catagoryId))}
        </Grid>
      ) : (
        <CircularProgress />
      )}
    </div>
  );
};
